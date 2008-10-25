-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, weight, rank) VALUES ('standard', 10.71, 94.06, 37);
INSERT INTO layout_items (token, ratio, weight, rank) VALUES ('staging', 52.68, 97.96, 82);

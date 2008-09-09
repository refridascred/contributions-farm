-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, weight, ratio, level) VALUES ('staging', 25.01, 18.69, 38);
INSERT INTO layout_items (owner, weight, ratio, level) VALUES ('edge', 44.11, 46.09, 32);

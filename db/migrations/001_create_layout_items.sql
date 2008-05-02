-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, ratio, weight) VALUES ('standard', 76.24, 58.99);
INSERT INTO layout_items (token, ratio, weight) VALUES ('cached', 47.96, 37.04);
INSERT INTO layout_items (token, ratio, weight) VALUES ('staging', 65.52, 55.77);

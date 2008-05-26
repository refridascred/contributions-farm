-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, weight) VALUES ('blue', 96.6, 50.86);
INSERT INTO layout_items (token, ratio, weight) VALUES ('green', 74.62, 64.13);

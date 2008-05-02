-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, score, token, weight) VALUES ('latest', 85.05, 59.87, 'eu-west', 90.52);
INSERT INTO layout_items (region, ratio, score, token, weight) VALUES ('edge', 49.46, 45.16, 'green', 71.9);

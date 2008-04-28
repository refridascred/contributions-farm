-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, region, score) VALUES (13.61, 'strict', 44.98);
INSERT INTO layout_items (weight, region, score) VALUES (13.93, 'latest', 37.81);
INSERT INTO layout_items (weight, region, score) VALUES (66.15, 'blue', 70.73);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, weight, count) VALUES ('strict', 46.97, 14);
INSERT INTO layout_items (region, weight, count) VALUES ('primary', 41.64, 0);
INSERT INTO layout_items (region, weight, count) VALUES ('latest', 98.77, 38);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, weight, level) VALUES ('green', 28.95, 79);
INSERT INTO layout_items (region, weight, level) VALUES ('latest', 40.91, 11);

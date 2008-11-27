-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, weight) VALUES ('local', 14.12, 53.96);
INSERT INTO layout_items (region, ratio, weight) VALUES ('latest', 83.88, 14.1);
INSERT INTO layout_items (region, ratio, weight) VALUES ('cached', 54.54, 59.65);

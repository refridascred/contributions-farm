-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, weight) VALUES ('blue', 60.93);
INSERT INTO layout_items (region, weight) VALUES ('stable', 69.25);
INSERT INTO layout_items (region, weight) VALUES ('legacy', 77.18);

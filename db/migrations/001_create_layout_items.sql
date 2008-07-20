-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, active, weight) VALUES ('primary', 94, 16.7);
INSERT INTO layout_items (region, active, weight) VALUES ('primary', 80, 37.57);
INSERT INTO layout_items (region, active, weight) VALUES ('standard', 19, 68.43);

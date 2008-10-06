-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, region, active) VALUES (73.73, 'primary', 91);
INSERT INTO layout_items (weight, region, active) VALUES (71.27, 'stable', 29);
INSERT INTO layout_items (weight, region, active) VALUES (8.1, 'strict', 48);

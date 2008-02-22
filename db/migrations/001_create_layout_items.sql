-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, label, region, active) VALUES (38.97, 'green', 'strict', 44);
INSERT INTO layout_items (weight, label, region, active) VALUES (26.94, 'eu-west', 'standard', 52);
INSERT INTO layout_items (weight, label, region, active) VALUES (30.23, 'local', 'stable', 75);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, active, region) VALUES (55.68, 82, 'open');
INSERT INTO layout_items (weight, active, region) VALUES (82.44, 53, 'blue');
INSERT INTO layout_items (weight, active, region) VALUES (65.15, 5, 'blue');

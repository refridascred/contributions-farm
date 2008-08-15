-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, active, level) VALUES (24.95, 14, 94);
INSERT INTO layout_items (weight, active, level) VALUES (44.42, 52, 86);
INSERT INTO layout_items (weight, active, level) VALUES (56.4, 51, 21);

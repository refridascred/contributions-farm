-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, count, active) VALUES (77.23, 7, 11);
INSERT INTO layout_items (ratio, count, active) VALUES (34.81, 20, 97);
INSERT INTO layout_items (ratio, count, active) VALUES (50.33, 37, 27);

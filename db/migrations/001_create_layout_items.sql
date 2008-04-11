-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, active, owner) VALUES (42.92, 8, 'legacy');
INSERT INTO layout_items (ratio, active, owner) VALUES (89.25, 28, 'legacy');
INSERT INTO layout_items (ratio, active, owner) VALUES (26.28, 70, 'green');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, ratio, count, active, token) VALUES (27.53, 21.54, 50, 80, 'local');
INSERT INTO layout_items (weight, ratio, count, active, token) VALUES (47.94, 73.11, 68, 87, 'cached');
INSERT INTO layout_items (weight, ratio, count, active, token) VALUES (65.74, 37.63, 95, 77, 'stable');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, active, token) VALUES (15.6, 12, 'staging');
INSERT INTO layout_items (ratio, active, token) VALUES (32.31, 11, 'cached');
INSERT INTO layout_items (ratio, active, token) VALUES (82.18, 29, 'stable');

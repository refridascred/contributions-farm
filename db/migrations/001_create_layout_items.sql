-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, token, count, active) VALUES (2.78, 'blue', 96, 69);
INSERT INTO layout_items (ratio, token, count, active) VALUES (80.06, 'fallback', 76, 55);
INSERT INTO layout_items (ratio, token, count, active) VALUES (58.16, 'staging', 56, 62);

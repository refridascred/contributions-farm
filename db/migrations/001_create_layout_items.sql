-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, count, ratio, token) VALUES (50, 27, 3.03, 'standard');
INSERT INTO layout_items (active, count, ratio, token) VALUES (64, 70, 37.22, 'open');
INSERT INTO layout_items (active, count, ratio, token) VALUES (71, 49, 98.11, 'local');

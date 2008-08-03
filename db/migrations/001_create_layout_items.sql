-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, active, token) VALUES (36.39, 18, 'blue');
INSERT INTO layout_items (ratio, active, token) VALUES (75.05, 52, 'blue');

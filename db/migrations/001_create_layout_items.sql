-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, level, token) VALUES (5, 42, 'stable');
INSERT INTO layout_items (active, level, token) VALUES (31, 43, 'fallback');
INSERT INTO layout_items (active, level, token) VALUES (76, 3, 'green');

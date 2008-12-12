-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, level, token) VALUES (49, 39, 'open');
INSERT INTO layout_items (active, level, token) VALUES (63, 34, 'latest');
INSERT INTO layout_items (active, level, token) VALUES (2, 30, 'primary');

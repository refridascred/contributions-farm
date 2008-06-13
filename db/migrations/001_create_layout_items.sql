-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, ratio, state) VALUES (48, 'standard', 32.99, 'standard');
INSERT INTO layout_items (count, token, ratio, state) VALUES (50, 'primary', 2.86, 'primary');

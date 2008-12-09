-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, state) VALUES (13, 'blue', 'stable');
INSERT INTO layout_items (count, token, state) VALUES (69, 'eu-west', 'stable');
INSERT INTO layout_items (count, token, state) VALUES (7, 'standard', 'local');

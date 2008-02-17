-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, state, region) VALUES (83, 'primary', 'strict', 'primary');
INSERT INTO layout_items (count, token, state, region) VALUES (73, 'strict', 'blue', 'latest');
INSERT INTO layout_items (count, token, state, region) VALUES (74, 'primary', 'stable', 'primary');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, state, level, token, owner) VALUES (11, 'edge', 27, 'latest', 'standard');
INSERT INTO layout_items (count, state, level, token, owner) VALUES (90, 'edge', 62, 'strict', 'edge');
INSERT INTO layout_items (count, state, level, token, owner) VALUES (53, 'strict', 96, 'cached', 'legacy');

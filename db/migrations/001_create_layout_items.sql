-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, state, owner, score) VALUES (27, 'edge', 'blue', 77.83);
INSERT INTO layout_items (active, state, owner, score) VALUES (88, 'fallback', 'latest', 50.13);
INSERT INTO layout_items (active, state, owner, score) VALUES (11, 'blue', 'cached', 77.76);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, owner, state, score) VALUES (62, 'legacy', 'open', 88.14);
INSERT INTO layout_items (level, owner, state, score) VALUES (95, 'open', 'stable', 95.71);
INSERT INTO layout_items (level, owner, state, score) VALUES (98, 'stable', 'local', 89.99);

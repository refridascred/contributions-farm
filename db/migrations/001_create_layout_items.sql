-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, state, owner, ratio) VALUES (27, 'fallback', 'strict', 39.08);
INSERT INTO layout_items (active, state, owner, ratio) VALUES (28, 'stable', 'edge', 28.93);

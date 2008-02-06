-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, state, ratio) VALUES (17, 'strict', 70.32);
INSERT INTO layout_items (active, state, ratio) VALUES (4, 'legacy', 4.47);
INSERT INTO layout_items (active, state, ratio) VALUES (13, 'latest', 93.04);

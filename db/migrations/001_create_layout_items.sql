-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, active, state, label) VALUES (53, 19, 'edge', 'open');
INSERT INTO layout_items (level, active, state, label) VALUES (73, 50, 'edge', 'edge');
INSERT INTO layout_items (level, active, state, label) VALUES (32, 84, 'legacy', 'fallback');

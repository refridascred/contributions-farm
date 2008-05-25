-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, active, label, owner) VALUES ('primary', 75, 'stable', 'local');
INSERT INTO layout_items (state, active, label, owner) VALUES ('local', 20, 'legacy', 'fallback');
INSERT INTO layout_items (state, active, label, owner) VALUES ('blue', 81, 'legacy', 'legacy');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, owner, active) VALUES ('latest', 'standard', 38);
INSERT INTO layout_items (state, owner, active) VALUES ('blue', 'fallback', 85);
INSERT INTO layout_items (state, owner, active) VALUES ('open', 'stable', 4);

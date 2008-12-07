-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, active, score, state) VALUES ('blue', 21, 89.15, 'strict');

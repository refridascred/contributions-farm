-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, active, rank, state) VALUES ('staging', 16, 26, 'staging');
INSERT INTO layout_items (owner, active, rank, state) VALUES ('green', 39, 0, 'blue');
INSERT INTO layout_items (owner, active, rank, state) VALUES ('fallback', 84, 49, 'open');

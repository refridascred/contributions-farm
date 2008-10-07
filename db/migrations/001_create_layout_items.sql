-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, state, level, owner, label) VALUES (53, 'stable', 0, 'primary', 'open');
INSERT INTO layout_items (rank, state, level, owner, label) VALUES (8, 'edge', 86, 'eu-west', 'eu-west');
INSERT INTO layout_items (rank, state, level, owner, label) VALUES (42, 'fallback', 5, 'eu-west', 'green');

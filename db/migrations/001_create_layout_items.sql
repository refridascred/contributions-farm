-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, level, region, state, owner) VALUES (16, 65, 'open', 'eu-west', 'open');
INSERT INTO layout_items (rank, level, region, state, owner) VALUES (34, 49, 'edge', 'stable', 'eu-west');
INSERT INTO layout_items (rank, level, region, state, owner) VALUES (70, 78, 'edge', 'fallback', 'stable');

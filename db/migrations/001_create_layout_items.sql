-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, owner, active, score) VALUES ('local', 'open', 52, 71.61);
INSERT INTO layout_items (state, owner, active, score) VALUES ('edge', 'edge', 14, 43.02);
INSERT INTO layout_items (state, owner, active, score) VALUES ('legacy', 'eu-west', 92, 24.15);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, owner, state, score) VALUES (70, 'open', 'open', 16.55);
INSERT INTO layout_items (rank, owner, state, score) VALUES (17, 'standard', 'stable', 81.65);
INSERT INTO layout_items (rank, owner, state, score) VALUES (48, 'standard', 'staging', 13.39);

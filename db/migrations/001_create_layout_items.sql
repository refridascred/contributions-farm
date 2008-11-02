-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, state) VALUES (13.58, 'cached', 'legacy');
INSERT INTO layout_items (score, owner, state) VALUES (37.15, 'cached', 'strict');
INSERT INTO layout_items (score, owner, state) VALUES (14.61, 'legacy', 'open');

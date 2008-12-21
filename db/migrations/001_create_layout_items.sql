-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, level, owner, state) VALUES (22.58, 33, 'legacy', 'green');
INSERT INTO layout_items (score, level, owner, state) VALUES (9.7, 85, 'latest', 'legacy');

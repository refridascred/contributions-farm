-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, state, ratio, score, token) VALUES ('primary', 'strict', 33.55, 13.79, 'latest');
INSERT INTO layout_items (owner, state, ratio, score, token) VALUES ('open', 'cached', 65.92, 87.84, 'stable');

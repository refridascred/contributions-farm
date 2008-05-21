-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, token, score, level, state) VALUES (50, 'standard', 40.2, 3, 'latest');
INSERT INTO layout_items (count, token, score, level, state) VALUES (4, 'primary', 91.16, 29, 'green');
INSERT INTO layout_items (count, token, score, level, state) VALUES (93, 'open', 18.03, 84, 'edge');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, score, owner, label) VALUES (34, 14.39, 'blue', 'edge');
INSERT INTO layout_items (active, score, owner, label) VALUES (20, 70.63, 'legacy', 'stable');
INSERT INTO layout_items (active, score, owner, label) VALUES (95, 23.73, 'standard', 'stable');

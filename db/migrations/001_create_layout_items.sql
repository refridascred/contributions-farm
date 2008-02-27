-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, label) VALUES (49.82, 'strict', 'primary');
INSERT INTO layout_items (score, owner, label) VALUES (64.52, 'legacy', 'edge');
INSERT INTO layout_items (score, owner, label) VALUES (50.85, 'primary', 'stable');

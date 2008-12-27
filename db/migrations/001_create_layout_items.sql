-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, owner, active, weight) VALUES (61.7, 'fallback', 66, 19.15);
INSERT INTO layout_items (score, owner, active, weight) VALUES (82.82, 'stable', 60, 34.51);
INSERT INTO layout_items (score, owner, active, weight) VALUES (97.22, 'eu-west', 94, 44.88);

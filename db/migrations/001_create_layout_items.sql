-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, state, score, active) VALUES (72.21, 'staging', 37.64, 86);
INSERT INTO layout_items (weight, state, score, active) VALUES (44.58, 'eu-west', 17.79, 51);
INSERT INTO layout_items (weight, state, score, active) VALUES (81.42, 'local', 84.5, 71);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, weight, score, label) VALUES ('cached', 75.93, 43.7, 'edge');
INSERT INTO layout_items (owner, weight, score, label) VALUES ('eu-west', 21.67, 67.85, 'green');
INSERT INTO layout_items (owner, weight, score, label) VALUES ('staging', 28.63, 51.57, 'stable');

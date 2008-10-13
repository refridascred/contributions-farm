-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score, ratio, state) VALUES ('standard', 76.14, 49.54, 'edge');
INSERT INTO layout_items (label, score, ratio, state) VALUES ('strict', 95.81, 44.05, 'standard');

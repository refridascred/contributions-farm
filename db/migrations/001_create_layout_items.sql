-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, state, score, label, weight) VALUES ('strict', 'staging', 48.38, 'edge', 50.45);
INSERT INTO layout_items (owner, state, score, label, weight) VALUES ('primary', 'green', 93.52, 'standard', 95.1);
INSERT INTO layout_items (owner, state, score, label, weight) VALUES ('staging', 'green', 23.62, 'blue', 0.43);

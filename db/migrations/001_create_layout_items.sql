-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, rank, ratio, state, label) VALUES (0.73, 36, 3.7, 'standard', 'latest');
INSERT INTO layout_items (score, rank, ratio, state, label) VALUES (37.8, 93, 1.63, 'cached', 'local');

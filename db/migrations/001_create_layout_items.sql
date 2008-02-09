-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, score, weight, owner, state) VALUES ('edge', 54.77, 94.57, 'local', 'stable');
INSERT INTO layout_items (label, score, weight, owner, state) VALUES ('edge', 21.73, 51.31, 'standard', 'fallback');
INSERT INTO layout_items (label, score, weight, owner, state) VALUES ('standard', 85.13, 70.78, 'open', 'local');

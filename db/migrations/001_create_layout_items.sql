-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, label, active, score) VALUES ('stable', 'local', 15, 26.54);
INSERT INTO layout_items (state, label, active, score) VALUES ('eu-west', 'open', 68, 56.67);

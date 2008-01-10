-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, label, state, score, count) VALUES ('eu-west', 'legacy', 'latest', 67.63, 67);
INSERT INTO layout_items (token, label, state, score, count) VALUES ('standard', 'cached', 'staging', 81.8, 66);

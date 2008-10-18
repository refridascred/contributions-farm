-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, label, token, score, weight) VALUES ('latest', 'strict', 'open', 37.06, 36.09);
INSERT INTO layout_items (state, label, token, score, weight) VALUES ('stable', 'fallback', 'open', 50.73, 24.98);

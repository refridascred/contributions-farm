-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, score, label, count, state) VALUES ('latest', 71.47, 'standard', 41, 'open');
INSERT INTO layout_items (owner, score, label, count, state) VALUES ('fallback', 78.55, 'local', 47, 'cached');

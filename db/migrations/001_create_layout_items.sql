-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, level, score, state, label) VALUES ('blue', 96, 73.01, 'blue', 'cached');
INSERT INTO layout_items (owner, level, score, state, label) VALUES ('stable', 66, 64.84, 'eu-west', 'local');

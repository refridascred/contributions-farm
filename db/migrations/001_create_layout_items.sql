-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, state, owner, ratio, token) VALUES ('stable', 'cached', 'open', 91.7, 'blue');
INSERT INTO layout_items (label, state, owner, ratio, token) VALUES ('eu-west', 'stable', 'staging', 2.76, 'standard');
INSERT INTO layout_items (label, state, owner, ratio, token) VALUES ('primary', 'blue', 'eu-west', 38.76, 'stable');

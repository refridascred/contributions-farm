-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, token, state, level, label) VALUES ('fallback', 'staging', 'open', 43, 'primary');
INSERT INTO layout_items (owner, token, state, level, label) VALUES ('legacy', 'open', 'strict', 98, 'edge');
INSERT INTO layout_items (owner, token, state, level, label) VALUES ('open', 'strict', 'eu-west', 43, 'latest');

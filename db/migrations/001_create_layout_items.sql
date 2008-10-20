-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, state, level, label) VALUES ('fallback', 'strict', 77, 'primary');
INSERT INTO layout_items (token, state, level, label) VALUES ('staging', 'latest', 74, 'cached');
INSERT INTO layout_items (token, state, level, label) VALUES ('open', 'green', 57, 'blue');

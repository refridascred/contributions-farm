-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, level, state, ratio) VALUES ('local', 40, 'eu-west', 10.92);
INSERT INTO layout_items (owner, level, state, ratio) VALUES ('fallback', 43, 'strict', 76.35);
INSERT INTO layout_items (owner, level, state, ratio) VALUES ('latest', 28, 'green', 69.85);

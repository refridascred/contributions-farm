-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, token, level, state) VALUES ('open', 'cached', 2, 'stable');
INSERT INTO layout_items (region, token, level, state) VALUES ('eu-west', 'open', 77, 'staging');
INSERT INTO layout_items (region, token, level, state) VALUES ('staging', 'legacy', 75, 'legacy');

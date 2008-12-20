-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, rank, region, state) VALUES ('strict', 20, 'eu-west', 'primary');
INSERT INTO layout_items (owner, rank, region, state) VALUES ('cached', 77, 'local', 'open');
INSERT INTO layout_items (owner, rank, region, state) VALUES ('fallback', 76, 'latest', 'cached');
